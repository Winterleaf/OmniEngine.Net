


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
    [TypeConverter(typeof(TypeConverterGeneric<Lightning_Base>))]
    public partial class Lightning_Base: GameBase
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(Lightning_Base ts, string simobjectid)
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
        public static bool operator !=(Lightning_Base ts, string simobjectid)
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
        public static implicit operator string( Lightning_Base ts)
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
        public static implicit operator Lightning_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (Lightning_Base) Omni.self.getSimObject(simobjectid,typeof(Lightning_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( Lightning_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator Lightning_Base(int simobjectid)
            {
            return  (Lightning) Omni.self.getSimObject((uint)simobjectid,typeof(Lightning_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( Lightning_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator Lightning_Base(uint simobjectid)
            {
            return  (Lightning_Base) Omni.self.getSimObject(simobjectid,typeof(Lightning_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Radial distance from the center of the Lightning object for the    start point of the bolt.\n\n   The actual start point will be a random point within this radius. 
/// </summary>
[MemberGroup("Bolts")]
public float boltStartRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".boltStartRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".boltStartRadius", value.AsString());
          }
       }
/// <summary>
/// Percentage chance (0-1) that a given lightning bolt will hit something. 
/// </summary>
[MemberGroup("Bolts")]
public float chanceToHitTarget
       {
       get
          {
          return Omni.self.GetVar(_ID + ".chanceToHitTarget").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".chanceToHitTarget", value.AsString());
          }
       }
/// <summary>
/// Color to blend the strike texture with. 
/// </summary>
[MemberGroup("Colors")]
public ColorF color
       {
       get
          {
          return Omni.self.GetVar(_ID + ".color").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".color", value.AsString());
          }
       }
/// <summary>
/// @brief Color to blend the strike texture with when the bolt is fading away.\n\n   Bolts fade away automatically shortly after the strike occurs. 
/// </summary>
[MemberGroup("Colors")]
public ColorF fadeColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeColor", value.AsString());
          }
       }
/// <summary>
/// @brief Horizontal size (XY plane) of the search box used to find and    damage Player or Vehicle objects within range of the strike.\n\n   Only the object at highest altitude with a clear line of sight to the    bolt will be hit. 
/// </summary>
[MemberGroup("Strikes")]
public float strikeRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".strikeRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".strikeRadius", value.AsString());
          }
       }
/// <summary>
/// @brief Number of lightning strikes to perform per minute.\n\n   Automatically invokes strikeRandomPoint() at regular intervals. 
/// </summary>
[MemberGroup("Strikes")]
public int strikesPerMinute
       {
       get
          {
          return Omni.self.GetVar(_ID + ".strikesPerMinute").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".strikesPerMinute", value.AsString());
          }
       }
/// <summary>
/// Width of a lightning bolt. 
/// </summary>
[MemberGroup("Strikes")]
public float strikeWidth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".strikeWidth").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".strikeWidth", value.AsString());
          }
       }
/// <summary>
/// Controls whether lightning bolts are affected by fog when they are rendered. 
/// </summary>
[MemberGroup("Bolts")]
public bool useFog
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useFog").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useFog", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Creates a LightningStrikeEvent which strikes a specific object.
///    @note This method is currently unimplemented. )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void strikeObject(string pSB){

pInvokes.m_ts.fnLightning_strikeObject(_ID, pSB);
}
/// <summary>
/// Creates a LightningStrikeEvent which attempts to strike and damage a random 
///    object in range of the Lightning object.
///    @tsexample
///    // Generate a damaging lightning strike effect on all clients
///    %lightning.strikeRandomPoint();
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void strikeRandomPoint(){

pInvokes.m_ts.fnLightning_strikeRandomPoint(_ID);
}
/// <summary>
/// @brief Creates a LightningStrikeEvent that triggers harmless lightning 
///    bolts on all clients.
///    No objects will be damaged by these bolts.
///    @tsexample
///    // Generate a harmless lightning strike effect on all clients
///    %lightning.warningFlashes();
///    @endtsexample )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void warningFlashes(){

pInvokes.m_ts.fnLightning_warningFlashes(_ID);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Informs an object that it was hit by a lightning bolt and needs to take damage.   @param hitPosition World position hit by the lightning bolt.   @param hitNormal Surface normal at @a hitPosition.   @param hitObject Player or Vehicle object that was hit.   @tsexample   function Lightning::applyDamage( %this, %hitPosition, %hitNormal, %hitObject )   {      // apply damage to the player      %hitObject.applyDamage( 25 )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void applyDamage(string hitPosition, string hitNormal, SceneObject hitObject){}

#endregion
public Lightning_Base (){}
}}
