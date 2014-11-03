


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
    [TypeConverter(typeof(TypeConverterGeneric<SpawnSphere_Base>))]
    public partial class SpawnSphere_Base: MissionMarker
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SpawnSphere_Base ts, string simobjectid)
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
        public static bool operator !=(SpawnSphere_Base ts, string simobjectid)
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
        public static implicit operator string( SpawnSphere_Base ts)
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
        public static implicit operator SpawnSphere_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SpawnSphere_Base) Omni.self.getSimObject(simobjectid,typeof(SpawnSphere_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SpawnSphere_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SpawnSphere_Base(int simobjectid)
            {
            return  (SpawnSphere) Omni.self.getSimObject((uint)simobjectid,typeof(SpawnSphere_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SpawnSphere_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SpawnSphere_Base(uint simobjectid)
            {
            return  (SpawnSphere_Base) Omni.self.getSimObject(simobjectid,typeof(SpawnSphere_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Flag to spawn object as soon as SpawnSphere is created, true to enable or false to disable. 
/// </summary>
[MemberGroup("Spawn")]
public bool autoSpawn
       {
       get
          {
          return Omni.self.GetVar(_ID + ".autoSpawn").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".autoSpawn", value.AsString());
          }
       }
/// <summary>
/// Deprecated 
/// </summary>
[MemberGroup("Weight")]
public float indoorWeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".indoorWeight").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".indoorWeight", value.AsString());
          }
       }
/// <summary>
/// Deprecated 
/// </summary>
[MemberGroup("Weight")]
public float outdoorWeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".outdoorWeight").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".outdoorWeight", value.AsString());
          }
       }
/// <summary>
/// Deprecated 
/// </summary>
[MemberGroup("Dimensions")]
public float radius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".radius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".radius", value.AsString());
          }
       }
/// <summary>
/// Object class to create (eg. Player, AIPlayer, Debris etc) 
/// </summary>
[MemberGroup("Spawn")]
public String spawnClass
       {
       get
          {
          return Omni.self.GetVar(_ID + ".spawnClass").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".spawnClass", value.AsString());
          }
       }
/// <summary>
/// Predefined datablock assigned to the object when created 
/// </summary>
[MemberGroup("Spawn")]
public String spawnDatablock
       {
       get
          {
          return Omni.self.GetVar(_ID + ".spawnDatablock").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".spawnDatablock", value.AsString());
          }
       }
/// <summary>
/// String containing semicolon (;) delimited properties to set when the object is created. 
/// </summary>
[MemberGroup("Spawn")]
public String spawnProperties
       {
       get
          {
          return Omni.self.GetVar(_ID + ".spawnProperties").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".spawnProperties", value.AsString());
          }
       }
/// <summary>
/// Command to execute immediately after spawning an object. New object id is stored in $SpawnObject. Max 255 characters. 
/// </summary>
[MemberGroup("Spawn")]
public String spawnScript
       {
       get
          {
          return Omni.self.GetVar(_ID + ".spawnScript").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".spawnScript", value.AsString());
          }
       }
/// <summary>
/// Flag to set the spawned object's transform to the SpawnSphere's transform. 
/// </summary>
[MemberGroup("Spawn")]
public bool spawnTransform
       {
       get
          {
          return Omni.self.GetVar(_ID + ".spawnTransform").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".spawnTransform", value.AsString());
          }
       }
/// <summary>
/// Deprecated 
/// </summary>
[MemberGroup("Weight")]
public float sphereWeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".sphereWeight").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".sphereWeight", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// ([string additionalProps]) Spawns the object based on the SpawnSphere's 
///    class, datablock, properties, and script settings. Allows you to pass in 
///    extra properties.
///    @hide )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  int spawnObject(string additionalProps){

return pInvokes.m_ts.fn_SpawnSphere_spawnObject(_ID, additionalProps);
}

#endregion
#region T3D Callbacks

        /// <summary>
        /// Called when the SpawnSphere is being created.   @param objectId The unique SimObjectId generated when SpawnSphere is created (%%this in script) )
        /// </summary>
        [ConsoleInteraction(true)]
public virtual  void onAdd(uint objectId){}

#endregion
public SpawnSphere_Base (){}
}}
