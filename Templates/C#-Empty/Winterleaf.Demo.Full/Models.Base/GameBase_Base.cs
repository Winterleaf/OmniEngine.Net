


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
    [TypeConverter(typeof(TypeConverterGeneric<GameBase_Base>))]
    public partial class GameBase_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GameBase_Base ts, string simobjectid)
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
        public static bool operator !=(GameBase_Base ts, string simobjectid)
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
        public static implicit operator string( GameBase_Base ts)
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
        public static implicit operator GameBase_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GameBase_Base) Omni.self.getSimObject(simobjectid,typeof(GameBase_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GameBase_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GameBase_Base(int simobjectid)
            {
            return  (GameBase) Omni.self.getSimObject((uint)simobjectid,typeof(GameBase_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GameBase_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GameBase_Base(uint simobjectid)
            {
            return  (GameBase_Base) Omni.self.getSimObject(simobjectid,typeof(GameBase_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Script datablock used for game objects. 
/// </summary>
[MemberGroup("Game")]
public GameBaseData dataBlock
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dataBlock");
          }
       set
          {
          Omni.self.SetVar(_ID + ".dataBlock", value.ToString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// @brief Apply an impulse to this object as defined by a world position and velocity vector.
/// 
///    @param pos impulse world position
///    @param vel impulse velocity (impulse force F = m * v)
///    @return Always true
/// 
///    @note Not all objects that derrive from GameBase have this defined.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool applyImpulse(Point3F pos, Point3F vel){

return pInvokes.m_ts.fnGameBase_applyImpulse(_ID, pos.AsString(), vel.AsString());
}
/// <summary>
/// @brief Applies a radial impulse to the object using the given origin and force.
/// 
///    @param origin World point of origin of the radial impulse.
///    @param radius The radius of the impulse area.
///    @param magnitude The strength of the impulse.
///    
///    @note Not all objects that derrive from GameBase have this defined.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void applyRadialImpulse(Point3F origin, float radius, float magnitude){

pInvokes.m_ts.fnGameBase_applyRadialImpulse(_ID, origin.AsString(), radius, magnitude);
}
/// <summary>
/// @brief Get the datablock used by this object.
///    @return the datablock this GameBase is using.
///    @see setDataBlock())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getDataBlock(){

return pInvokes.m_ts.fnGameBase_getDataBlock(_ID);
}
/// <summary>
/// @brief Assign this GameBase to use the specified datablock.
///    @param data new datablock to use
///    @return true if successful, false if failed.
///    @see getDataBlock())
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setDataBlock(string data){

return pInvokes.m_ts.fnGameBase_setDataBlock(_ID, data);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called when the client controlling the object changes.   @param controlled true if a client now controls this object, false if no    client controls this object. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void setControl(bool controlled){}

#endregion
public GameBase_Base (){}
}}
