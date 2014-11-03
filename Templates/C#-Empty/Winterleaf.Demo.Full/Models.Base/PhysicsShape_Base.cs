


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
    [TypeConverter(typeof(TypeConverterGeneric<PhysicsShape_Base>))]
    public partial class PhysicsShape_Base: GameBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PhysicsShape_Base ts, string simobjectid)
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
        public static bool operator !=(PhysicsShape_Base ts, string simobjectid)
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
        public static implicit operator string( PhysicsShape_Base ts)
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
        public static implicit operator PhysicsShape_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (PhysicsShape_Base) Omni.self.getSimObject(simobjectid,typeof(PhysicsShape_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( PhysicsShape_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PhysicsShape_Base(int simobjectid)
            {
            return  (PhysicsShape) Omni.self.getSimObject((uint)simobjectid,typeof(PhysicsShape_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( PhysicsShape_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PhysicsShape_Base(uint simobjectid)
            {
            return  (PhysicsShape_Base) Omni.self.getSimObject(simobjectid,typeof(PhysicsShape_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Enables or disables playing of an ambient animation upon loading the shape.\n\n      @note The ambient animation must be named \ambient\. 
/// </summary>
[MemberGroup("PhysicsShape")]
public bool playAmbient
       {
       get
          {
          return Omni.self.GetVar(_ID + ".playAmbient").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".playAmbient", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Disables rendering and physical simulation.
///    Calling destroy() will also spawn any explosions, debris, and/or destroyedShape 
///    defined for it, as well as remove it from the scene graph.
///    Destroyed objects are only created on the server. Ghosting will later update the client.
///    @note This does not actually delete the PhysicsShape. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void destroy(){

pInvokes.m_ts.fnPhysicsShape_destroy(_ID);
}
/// <summary>
/// @brief Returns if a PhysicsShape has been destroyed or not. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool isDestroyed(){

return pInvokes.m_ts.fnPhysicsShape_isDestroyed(_ID);
}
/// <summary>
/// @brief Restores the shape to its state before being destroyed.
///    Re-enables rendering and physical simulation on the object and 
///    adds it to the client's scene graph. 
///    Has no effect if the shape is not destroyed.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void restore(){

pInvokes.m_ts.fnPhysicsShape_restore(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public PhysicsShape_Base (){}
}}
