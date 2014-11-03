


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
    [TypeConverter(typeof(TypeConverterGeneric<LightAnimData_Base>))]
    public partial class LightAnimData_Base: SimDataBlock
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(LightAnimData_Base ts, string simobjectid)
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
        public static bool operator !=(LightAnimData_Base ts, string simobjectid)
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
        public static implicit operator string( LightAnimData_Base ts)
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
        public static implicit operator LightAnimData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (LightAnimData_Base) Omni.self.getSimObject(simobjectid,typeof(LightAnimData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( LightAnimData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator LightAnimData_Base(int simobjectid)
            {
            return  (LightAnimData) Omni.self.getSimObject((uint)simobjectid,typeof(LightAnimData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( LightAnimData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator LightAnimData_Base(uint simobjectid)
            {
            return  (LightAnimData_Base) Omni.self.getSimObject(simobjectid,typeof(LightAnimData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The value of the A key in the keyframe sequence. 
/// </summary>
[MemberGroup("Brightness")]
public float brightnessA
       {
       get
          {
          return Omni.self.GetVar(_ID + ".brightnessA").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".brightnessA", value.AsString());
          }
       }
/// <summary>
/// The keyframe sequence encoded into a string where characters from A to Z define      a position between the two animation values. 
/// </summary>
[MemberGroup("Brightness")]
public String brightnessKeys
       {
       get
          {
          return Omni.self.GetVar(_ID + ".brightnessKeys").AsString();
          }
       set
          {
          Omni.self.SetVar(_ID + ".brightnessKeys", value.AsString());
          }
       }
/// <summary>
/// The animation time for keyframe sequence. 
/// </summary>
[MemberGroup("Brightness")]
public float brightnessPeriod
       {
       get
          {
          return Omni.self.GetVar(_ID + ".brightnessPeriod").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".brightnessPeriod", value.AsString());
          }
       }
/// <summary>
/// If true the transition between keyframes will be smooth. 
/// </summary>
[MemberGroup("Brightness")]
public bool brightnessSmooth
       {
       get
          {
          return Omni.self.GetVar(_ID + ".brightnessSmooth").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".brightnessSmooth", value.AsString());
          }
       }
/// <summary>
/// The value of the Z key in the keyframe sequence. 
/// </summary>
[MemberGroup("Brightness")]
public float brightnessZ
       {
       get
          {
          return Omni.self.GetVar(_ID + ".brightnessZ").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".brightnessZ", value.AsString());
          }
       }
[MemberGroup("Color")]
public arrayObject<float> colorA;
[MemberGroup("Color")]
public arrayObject<String> colorKeys;
[MemberGroup("Color")]
public arrayObject<float> colorPeriod;
[MemberGroup("Color")]
public arrayObject<bool> colorSmooth;
[MemberGroup("Color")]
public arrayObject<float> colorZ;
[MemberGroup("Offset")]
public arrayObject<float> offsetA;
[MemberGroup("Offset")]
public arrayObject<String> offsetKeys;
[MemberGroup("Offset")]
public arrayObject<float> offsetPeriod;
[MemberGroup("Offset")]
public arrayObject<bool> offsetSmooth;
[MemberGroup("Offset")]
public arrayObject<float> offsetZ;
[MemberGroup("Rotation")]
public arrayObject<float> rotA;
[MemberGroup("Rotation")]
public arrayObject<String> rotKeys;
[MemberGroup("Rotation")]
public arrayObject<float> rotPeriod;
[MemberGroup("Rotation")]
public arrayObject<bool> rotSmooth;
[MemberGroup("Rotation")]
public arrayObject<float> rotZ;

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public LightAnimData_Base (){colorA = new arrayObject<float>(3,"colorA","TypeVariable",false,this);    
colorKeys = new arrayObject<String>(3,"colorKeys","TypeVariable",false,this);    
colorPeriod = new arrayObject<float>(3,"colorPeriod","TypeVariable",false,this);    
colorSmooth = new arrayObject<bool>(3,"colorSmooth","TypeVariable",false,this);    
colorZ = new arrayObject<float>(3,"colorZ","TypeVariable",false,this);    
offsetA = new arrayObject<float>(3,"offsetA","TypeVariable",false,this);    
offsetKeys = new arrayObject<String>(3,"offsetKeys","TypeVariable",false,this);    
offsetPeriod = new arrayObject<float>(3,"offsetPeriod","TypeVariable",false,this);    
offsetSmooth = new arrayObject<bool>(3,"offsetSmooth","TypeVariable",false,this);    
offsetZ = new arrayObject<float>(3,"offsetZ","TypeVariable",false,this);    
rotA = new arrayObject<float>(3,"rotA","TypeVariable",false,this);    
rotKeys = new arrayObject<String>(3,"rotKeys","TypeVariable",false,this);    
rotPeriod = new arrayObject<float>(3,"rotPeriod","TypeVariable",false,this);    
rotSmooth = new arrayObject<bool>(3,"rotSmooth","TypeVariable",false,this);    
rotZ = new arrayObject<float>(3,"rotZ","TypeVariable",false,this);    
}
}}
