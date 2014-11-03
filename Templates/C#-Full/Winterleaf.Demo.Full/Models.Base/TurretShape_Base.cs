


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
    [TypeConverter(typeof(TypeConverterGeneric<TurretShape_Base>))]
    public partial class TurretShape_Base: Item
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(TurretShape_Base ts, string simobjectid)
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
        public static bool operator !=(TurretShape_Base ts, string simobjectid)
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
        public static implicit operator string( TurretShape_Base ts)
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
        public static implicit operator TurretShape_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (TurretShape_Base) Omni.self.getSimObject(simobjectid,typeof(TurretShape_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( TurretShape_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator TurretShape_Base(int simobjectid)
            {
            return  (TurretShape) Omni.self.getSimObject((uint)simobjectid,typeof(TurretShape_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( TurretShape_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator TurretShape_Base(uint simobjectid)
            {
            return  (TurretShape_Base) Omni.self.getSimObject(simobjectid,typeof(TurretShape_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Respawn the turret after it has been destroyed.\n\n   If true, the turret will respawn after it is destroyed.\n
/// </summary>
[MemberGroup("")]
public bool respawn
       {
       get
          {
          return Omni.self.GetVar(_ID + ".respawn").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".respawn", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Does the turret respawn after it has been destroyed.
///    @returns True if the turret respawns.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool doRespawn(){

return pInvokes.m_ts.fnTurretShape_doRespawn(_ID);
}
/// <summary>
/// @brief Get if the turret is allowed to fire through moves.
///    @return True if the turret is allowed to fire through moves. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getAllowManualFire(){

return pInvokes.m_ts.fnTurretShape_getAllowManualFire(_ID);
}
/// <summary>
/// @brief Get if the turret is allowed to rotate through moves.
///    @return True if the turret is allowed to rotate through moves. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool getAllowManualRotation(){

return pInvokes.m_ts.fnTurretShape_getAllowManualRotation(_ID);
}
/// <summary>
/// @brief Get the name of the turret's current state.
/// 
///    The state is one of the following:ul>
///    li>Dead - The TurretShape is destroyed./li>
///    li>Mounted - The TurretShape is mounted to an object such as a vehicle./li>
///    li>Ready - The TurretShape is free to move.  The usual state./li>/ul>
/// 
///    @return The current state; one of: \"Dead\", \"Mounted\", \"Ready\" )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  string getState(){

return pInvokes.m_ts.fnTurretShape_getState(_ID);
}
/// <summary>
/// @brief Get Euler rotation of this turret's heading and pitch nodes.
///    @return the orientation of the turret's heading and pitch nodes in the 
///    form of rotations around the X, Y and Z axes in degrees. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  Point3F getTurretEulerRotation(){

return new Point3F ( pInvokes.m_ts.fnTurretShape_getTurretEulerRotation(_ID));
}
/// <summary>
/// @brief Set if the turret is allowed to fire through moves.
///    @param allow If true then the turret may be fired through moves.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAllowManualFire(bool allow){

pInvokes.m_ts.fnTurretShape_setAllowManualFire(_ID, allow);
}
/// <summary>
/// @brief Set if the turret is allowed to rotate through moves.
///    @param allow If true then the turret may be rotated through moves.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setAllowManualRotation(bool allow){

pInvokes.m_ts.fnTurretShape_setAllowManualRotation(_ID, allow);
}
/// <summary>
/// @brief Set Euler rotation of this turret's heading and pitch nodes in degrees.
///    @param rot The rotation in degrees.  The pitch is the X component and the 
///    heading is the Z component.  The Y component is ignored.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void setTurretEulerRotation(Point3F rot){

pInvokes.m_ts.fnTurretShape_setTurretEulerRotation(_ID, rot.AsString());
}

#endregion
#region T3D Callbacks

#endregion
public TurretShape_Base (){}
}}
