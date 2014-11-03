


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
    [TypeConverter(typeof(TypeConverterGeneric<PhysicsForce_Base>))]
    public partial class PhysicsForce_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PhysicsForce_Base ts, string simobjectid)
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
        public static bool operator !=(PhysicsForce_Base ts, string simobjectid)
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
        public static implicit operator string( PhysicsForce_Base ts)
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
        public static implicit operator PhysicsForce_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (PhysicsForce_Base) Omni.self.getSimObject(simobjectid,typeof(PhysicsForce_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( PhysicsForce_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PhysicsForce_Base(int simobjectid)
            {
            return  (PhysicsForce) Omni.self.getSimObject((uint)simobjectid,typeof(PhysicsForce_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( PhysicsForce_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PhysicsForce_Base(uint simobjectid)
            {
            return  (PhysicsForce_Base) Omni.self.getSimObject(simobjectid,typeof(PhysicsForce_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Attempts to associate the PhysicsForce with a PhysicsBody.
///    Performs a physics ray cast of the provided length and direction. The %PhysicsForce  
///    will attach itself to the first dynamic PhysicsBody the ray collides with. 
///    On every tick, the attached body will be attracted towards the position of the %PhysicsForce.
///    A %PhysicsForce can only be attached to one body at a time.
///    @note To determine if an %attach was successful, check isAttached() immediately after 
///    calling this function.n)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void attach(Point3F start, Point3F direction, float maxDist){

pInvokes.m_ts.fnPhysicsForce_attach(_ID, start.AsString(), direction.AsString(), maxDist);
}
/// <summary>
/// @brief Disassociates the PhysicsForce from any attached PhysicsBody.
///    @param force Optional force to apply to the attached PhysicsBody 
///    before detaching.
///    @note Has no effect if the %PhysicsForce is not attached to anything.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void detach(Point3F force = null ){
if (force== null) {force = new Point3F(0.0f, 0.0f, 0.0f);}

pInvokes.m_ts.fnPhysicsForce_detach(_ID, force.AsString());
}
/// <summary>
/// @brief Returns true if the %PhysicsForce is currently attached to an object.
///    @see PhysicsForce::attach())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isAttached(){

return pInvokes.m_ts.fnPhysicsForce_isAttached(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public PhysicsForce_Base (){}
}}
