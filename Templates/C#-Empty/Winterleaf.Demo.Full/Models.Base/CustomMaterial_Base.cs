


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
    [TypeConverter(typeof(TypeConverterGeneric<CustomMaterial_Base>))]
    public partial class CustomMaterial_Base: Material
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(CustomMaterial_Base ts, string simobjectid)
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
        public static bool operator !=(CustomMaterial_Base ts, string simobjectid)
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
        public static implicit operator string( CustomMaterial_Base ts)
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
        public static implicit operator CustomMaterial_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (CustomMaterial_Base) Omni.self.getSimObject(simobjectid,typeof(CustomMaterial_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( CustomMaterial_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator CustomMaterial_Base(int simobjectid)
            {
            return  (CustomMaterial) Omni.self.getSimObject((uint)simobjectid,typeof(CustomMaterial_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( CustomMaterial_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator CustomMaterial_Base(uint simobjectid)
            {
            return  (CustomMaterial_Base) Omni.self.getSimObject(simobjectid,typeof(CustomMaterial_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// @brief Alternate material for targeting lower end hardware.\n\n   If the CustomMaterial requires a higher pixel shader version than the one    it's using, it's fallback Material will be processed instead.    If the fallback material wasn't defined, Torque 3D will assert and attempt to use a very    basic material in it's place.\n\n
/// </summary>
[MemberGroup("")]
public Material fallback
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fallback");
          }
       set
          {
          Omni.self.SetVar(_ID + ".fallback", value.ToString());
          }
       }
/// <summary>
/// @brief Determines if the material should recieve lights in Basic Lighting.    Has no effect in Advanced Lighting.\n\n
/// </summary>
[MemberGroup("")]
public bool forwardLit
       {
       get
          {
          return Omni.self.GetVar(_ID + ".forwardLit").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".forwardLit", value.AsString());
          }
       }
/// <summary>
/// @brief Name of the ShaderData to use for this effect.\n\n
/// </summary>
[MemberGroup("")]
public String shader
       {
       get
          {
          return Omni.self.GetVar(_ID + ".shader").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".shader", value.AsString());
          }
       }
/// <summary>
/// @brief Name of a GFXStateBlockData for this effect.\n\n
/// </summary>
[MemberGroup("")]
public GFXStateBlockData stateBlock
       {
       get
          {
          return Omni.self.GetVar(_ID + ".stateBlock");
          }
       set
          {
          Omni.self.SetVar(_ID + ".stateBlock", value.ToString());
          }
       }
/// <summary>
/// @brief String identifier of this material's target texture.
/// </summary>
[MemberGroup("")]
public String target
       {
       get
          {
          return Omni.self.GetVar(_ID + ".target").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".target", value.AsString());
          }
       }
/// <summary>
/// @brief Specifies pixel shader version for hardware.\n\n   Valid pixel shader versions include 2.0, 3.0, etc.    @note All features aren't compatible with all pixel shader versions.
/// </summary>
[MemberGroup("")]
public float version
       {
       get
          {
          return Omni.self.GetVar(_ID + ".version").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".version", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public CustomMaterial_Base (){}
}}
