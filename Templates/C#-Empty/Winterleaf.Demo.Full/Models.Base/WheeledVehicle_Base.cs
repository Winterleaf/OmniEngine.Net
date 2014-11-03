


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
    [TypeConverter(typeof(TypeConverterGeneric<WheeledVehicle_Base>))]
    public partial class WheeledVehicle_Base: Vehicle
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(WheeledVehicle_Base ts, string simobjectid)
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
        public static bool operator !=(WheeledVehicle_Base ts, string simobjectid)
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
        public static implicit operator string( WheeledVehicle_Base ts)
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
        public static implicit operator WheeledVehicle_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (WheeledVehicle_Base) Omni.self.getSimObject(simobjectid,typeof(WheeledVehicle_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( WheeledVehicle_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator WheeledVehicle_Base(int simobjectid)
            {
            return  (WheeledVehicle) Omni.self.getSimObject((uint)simobjectid,typeof(WheeledVehicle_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( WheeledVehicle_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator WheeledVehicle_Base(uint simobjectid)
            {
            return  (WheeledVehicle_Base) Omni.self.getSimObject(simobjectid,typeof(WheeledVehicle_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions
/// <summary>
/// @brief Get the number of wheels on this vehicle.
///    @return the number of wheels (equal to the number of hub nodes defined in the model) )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int getWheelCount(){

return pInvokes.m_ts.fnWheeledVehicle_getWheelCount(_ID);
}
/// <summary>
/// @brief Set whether the wheel is powered (has torque applied from the engine).
///    A rear wheel drive car for example would set the front wheels to false, 
///    and the rear wheels to true.
///    @param wheel index of the wheel to set (hub node #)
///    @param powered flag indicating whether to power the wheel or not
///    @return true if successful, false if failed )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setWheelPowered(int wheel, bool powered){

return pInvokes.m_ts.fnWheeledVehicle_setWheelPowered(_ID, wheel, powered);
}
/// <summary>
/// @brief Set the WheeledVehicleSpring datablock for this wheel.
///    @param wheel index of the wheel to set (hub node #)
///    @param spring WheeledVehicleSpring datablock
///    @return true if successful, false if failed
///    @tsexample
///    %obj.setWheelSpring( 0, FrontSpring );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setWheelSpring(int wheel, string spring){

return pInvokes.m_ts.fnWheeledVehicle_setWheelSpring(_ID, wheel, spring);
}
/// <summary>
/// @brief Set how much the wheel is affected by steering.
///    The steering factor controls how much the wheel is rotated by the vehicle 
///    steering. For example, most cars would have their front wheels set to 1.0, 
///    and their rear wheels set to 0 since only the front wheels should turn.
///    Negative values will turn the wheel in the opposite direction to the steering 
///    angle.
///    @param wheel index of the wheel to set (hub node #)
///    @param steering steering factor from -1 (full inverse) to 1 (full)
///    @return true if successful, false if failed )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setWheelSteering(int wheel, float steering){

return pInvokes.m_ts.fnWheeledVehicle_setWheelSteering(_ID, wheel, steering);
}
/// <summary>
/// @brief Set the WheeledVehicleTire datablock for this wheel.
///    @param wheel index of the wheel to set (hub node #)
///    @param tire WheeledVehicleTire datablock
///    @return true if successful, false if failed
///    @tsexample
///    %obj.setWheelTire( 0, FrontTire );
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  bool setWheelTire(int wheel, string tire){

return pInvokes.m_ts.fnWheeledVehicle_setWheelTire(_ID, wheel, tire);
}

#endregion
#region T3D Callbacks

#endregion
public WheeledVehicle_Base (){}
}}
