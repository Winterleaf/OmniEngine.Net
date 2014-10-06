


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
    [TypeConverter(typeof(TypeConverterGeneric<SceneSimpleZone_Base>))]
    public partial class SceneSimpleZone_Base: SceneZoneSpace
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SceneSimpleZone_Base ts, string simobjectid)
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
        public static bool operator !=(SceneSimpleZone_Base ts, string simobjectid)
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
        public static implicit operator string( SceneSimpleZone_Base ts)
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
        public static implicit operator SceneSimpleZone_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SceneSimpleZone_Base) Omni.self.getSimObject(simobjectid,typeof(SceneSimpleZone_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SceneSimpleZone_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SceneSimpleZone_Base(int simobjectid)
            {
            return  (SceneSimpleZone) Omni.self.getSimObject((uint)simobjectid,typeof(SceneSimpleZone_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SceneSimpleZone_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SceneSimpleZone_Base(uint simobjectid)
            {
            return  (SceneSimpleZone_Base) Omni.self.getSimObject(simobjectid,typeof(SceneSimpleZone_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Color of ambient lighting in this zone.\n\n     Only used if #useAmbientLightColor is true. 
/// </summary>
[MemberGroup("Lighting")]
public ColorF ambientLightColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ambientLightColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ambientLightColor", value.AsString());
          }
       }
/// <summary>
/// Whether to use #ambientLightColor for ambient lighting in this zone or the global ambient color. 
/// </summary>
[MemberGroup("Lighting")]
public bool useAmbientLightColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".useAmbientLightColor").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".useAmbientLightColor", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public SceneSimpleZone_Base (){}
}}
