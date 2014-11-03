


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
    [TypeConverter(typeof(TypeConverterGeneric<RigidShape_Base>))]
    public partial class RigidShape_Base: ShapeBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(RigidShape_Base ts, string simobjectid)
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
        public static bool operator !=(RigidShape_Base ts, string simobjectid)
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
        public static implicit operator string( RigidShape_Base ts)
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
        public static implicit operator RigidShape_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (RigidShape_Base) Omni.self.getSimObject(simobjectid,typeof(RigidShape_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( RigidShape_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RigidShape_Base(int simobjectid)
            {
            return  (RigidShape) Omni.self.getSimObject((uint)simobjectid,typeof(RigidShape_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( RigidShape_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RigidShape_Base(uint simobjectid)
            {
            return  (RigidShape_Base) Omni.self.getSimObject(simobjectid,typeof(RigidShape_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Forces the client to jump to the RigidShape's transform rather then warp to it.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void forceClientTransform(){

pInvokes.m_ts.fnRigidShape_forceClientTransform(_ID);
}
/// <summary>
/// @brief Enables or disables the physics simulation on the RigidShape object.
///    @param isFrozen Boolean frozen state to set the object.
///    @tsexample
///    // Define the frozen state.
///    %isFrozen = \"true\";
///    // Inform the object of the defined frozen state
///    %thisRigidShape.freezeSim(%isFrozen);
///    @endtsexample
///    @see ShapeBaseData)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void freezeSim(bool isFrozen){

pInvokes.m_ts.fnRigidShape_freezeSim(_ID, isFrozen);
}
/// <summary>
/// @brief Clears physic forces from the shape and sets it at rest.
///    @tsexample
///    // Inform the RigidShape object to reset.
///    %thisRigidShape.reset();
///    @endtsexample
///    @see ShapeBaseData)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void reset(){

pInvokes.m_ts.fnRigidShape_reset(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called whenever this RigidShape object enters liquid.   @param objId The ID of the rigidShape object.   @param waterCoverage Amount of water coverage the RigidShape has.   @param liquidType Type of liquid that was entered.   @tsexample   // The RigidShape object falls in a body of liquid, causing the callback to occur.   RigidShape::onEnterLiquid(%this,%objId,%waterCoverage,%liquidType)   	{   		// Code to run whenever this callback occurs.   	}   @endtsexample   @see ShapeBase)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEnterLiquid(string objId, string waterCoverage, string liquidType){}

        /// <summary>
        /// @brief Called whenever the RigidShape object exits liquid.   @param objId The ID of the RigidShape object.   @param liquidType Type if liquid that was exited.   @tsexample   // The RigidShape object exits in a body of liquid, causing the callback to occur.   RigidShape::onLeaveLiquid(%this,%objId,%liquidType)   	{   		// Code to run whenever this callback occurs.   	}   @endtsexample   @see ShapeBase)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLeaveLiquid(string objId, string liquidType){}

#endregion
public RigidShape_Base (){}
}}
