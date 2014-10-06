


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
    [TypeConverter(typeof(TypeConverterGeneric<PlayerData_Base>))]
    public partial class PlayerData_Base: ShapeBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PlayerData_Base ts, string simobjectid)
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
        public static bool operator !=(PlayerData_Base ts, string simobjectid)
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
        public static implicit operator string( PlayerData_Base ts)
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
        public static implicit operator PlayerData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (PlayerData_Base) Omni.self.getSimObject(simobjectid,typeof(PlayerData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( PlayerData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PlayerData_Base(int simobjectid)
            {
            return  (PlayerData) Omni.self.getSimObject((uint)simobjectid,typeof(PlayerData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( PlayerData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PlayerData_Base(uint simobjectid)
            {
            return  (PlayerData_Base) Omni.self.getSimObject(simobjectid,typeof(PlayerData_Base));
            }
#endregion
#region Init Persists

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

        /// <summary>
        /// @brief Called when the player changes poses.   @param obj The Player object   @param oldPose The pose the player is switching from.   @param newPose The pose the player is switching to.)
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onPoseChange(Player obj, string oldPose, string newPose){}

        /// <summary>
        /// @brief Called when the player starts swimming.   @param obj The Player object )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onStartSwim(Player obj){}

        /// <summary>
        /// @brief Called when the player stops swimming.   @param obj The Player object )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onStopSwim(Player obj){}

        /// <summary>
        /// @brief Called when the player starts moving while in a Sprint pose.   @param obj The Player object )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onStartSprintMotion(Player obj){}

        /// <summary>
        /// @brief Called when the player stops moving while in a Sprint pose.   @param obj The Player object )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onStopSprintMotion(Player obj){}

        /// <summary>
        /// @brief Called when attempting to dismount the player from a vehicle.   It is up to the doDismount() method to actually perform the dismount.  Often    there are some conditions that prevent this, such as the vehicle moving too fast.   @param obj The Player object )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void doDismount(Player obj){}

        /// <summary>
        /// @brief Called when the player enters a liquid.   @param obj The Player object   @param coverage Percentage of the player's bounding box covered by the liquid   @param type The type of liquid the player has entered )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEnterLiquid(Player obj, float coverage, string type){}

        /// <summary>
        /// @brief Called when the player leaves a liquid.   @param obj The Player object   @param type The type of liquid the player has left )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLeaveLiquid(Player obj, string type){}

        /// <summary>
        /// @brief Called on the server when a scripted animation completes.   @param obj The Player object   @see Player::setActionThread() for setting a scripted animation and its 'hold' parameter to    determine if this callback is used. )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void animationDone(Player obj){}

        /// <summary>
        /// @brief Called when the player enters the mission area.   @param obj The Player object   @see MissionArea )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onEnterMissionArea(Player obj){}

        /// <summary>
        /// @brief Called when the player leaves the mission area.   @param obj The Player object   @see MissionArea )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onLeaveMissionArea(Player obj){}

#endregion
public PlayerData_Base (){}
}}
