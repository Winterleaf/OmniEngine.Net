


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
    [TypeConverter(typeof(TypeConverterGeneric<PrecipitationData_Base>))]
    public partial class PrecipitationData_Base: GameBaseData
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(PrecipitationData_Base ts, string simobjectid)
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
        public static bool operator !=(PrecipitationData_Base ts, string simobjectid)
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
        public static implicit operator string( PrecipitationData_Base ts)
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
        public static implicit operator PrecipitationData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (PrecipitationData_Base) Omni.self.getSimObject(simobjectid,typeof(PrecipitationData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( PrecipitationData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator PrecipitationData_Base(int simobjectid)
            {
            return  (PrecipitationData) Omni.self.getSimObject((uint)simobjectid,typeof(PrecipitationData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( PrecipitationData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator PrecipitationData_Base(uint simobjectid)
            {
            return  (PrecipitationData_Base) Omni.self.getSimObject(simobjectid,typeof(PrecipitationData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The name of the shader used for raindrops. 
/// </summary>
[MemberGroup("")]
public String dropShader
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dropShader").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dropShader", value.AsString());
          }
       }
/// <summary>
/// @brief How many rows and columns are in the raindrop texture.\n\n   For example, if the texture has 16 raindrops arranged in a grid, this    field should be set to 4. 
/// </summary>
[MemberGroup("")]
public int dropsPerSide
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dropsPerSide").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dropsPerSide", value.AsString());
          }
       }
/// <summary>
/// @brief Texture filename for drop particles.\n\n   The drop texture can contain several different drop sub-textures    arranged in a grid. There must be the same number of rows as columns. A    random frame will be chosen for each drop. 
/// </summary>
[MemberGroup("")]
public String dropTexture
       {
       get
          {
          return Omni.self.GetVar(_ID + ".dropTexture").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".dropTexture", value.AsString());
          }
       }
/// <summary>
/// Looping SFXProfile effect to play while Precipitation is active. 
/// </summary>
[MemberGroup("")]
public SFXTrack soundProfile
       {
       get
          {
          return Omni.self.GetVar(_ID + ".soundProfile");
          }
       set
          {
          Omni.self.SetVar(_ID + ".soundProfile", value.ToString());
          }
       }
/// <summary>
/// @brief How many rows and columns are in the splash texture.\n\n   For example, if the texture has 9 splashes arranged in a grid, this    field should be set to 3. 
/// </summary>
[MemberGroup("")]
public int splashesPerSide
       {
       get
          {
          return Omni.self.GetVar(_ID + ".splashesPerSide").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".splashesPerSide", value.AsString());
          }
       }
/// <summary>
/// The name of the shader used for splashes. 
/// </summary>
[MemberGroup("")]
public String splashShader
       {
       get
          {
          return Omni.self.GetVar(_ID + ".splashShader").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".splashShader", value.AsString());
          }
       }
/// <summary>
/// @brief Texture filename for splash particles.\n\n   The splash texture can contain several different splash sub-textures    arranged in a grid. There must be the same number of rows as columns. A    random frame will be chosen for each splash. 
/// </summary>
[MemberGroup("")]
public String splashTexture
       {
       get
          {
          return Omni.self.GetVar(_ID + ".splashTexture").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".splashTexture", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public PrecipitationData_Base (){}
}}
