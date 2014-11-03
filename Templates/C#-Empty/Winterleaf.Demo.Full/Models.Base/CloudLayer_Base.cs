


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
    [TypeConverter(typeof(TypeConverterGeneric<CloudLayer_Base>))]
    public partial class CloudLayer_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(CloudLayer_Base ts, string simobjectid)
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
        public static bool operator !=(CloudLayer_Base ts, string simobjectid)
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
        public static implicit operator string( CloudLayer_Base ts)
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
        public static implicit operator CloudLayer_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (CloudLayer_Base) Omni.self.getSimObject(simobjectid,typeof(CloudLayer_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( CloudLayer_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator CloudLayer_Base(int simobjectid)
            {
            return  (CloudLayer) Omni.self.getSimObject((uint)simobjectid,typeof(CloudLayer_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( CloudLayer_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator CloudLayer_Base(uint simobjectid)
            {
            return  (CloudLayer_Base) Omni.self.getSimObject(simobjectid,typeof(CloudLayer_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Base cloud color before lighting. 
/// </summary>
[MemberGroup("CloudLayer")]
public ColorF baseColor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".baseColor").AsColorF();
          }
       set
          {
          Omni.self.SetVar(_ID + ".baseColor", value.AsString());
          }
       }
/// <summary>
/// Fraction of sky covered by clouds 0-1. 
/// </summary>
[MemberGroup("CloudLayer")]
public float coverage
       {
       get
          {
          return Omni.self.GetVar(_ID + ".coverage").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".coverage", value.AsString());
          }
       }
/// <summary>
/// Brightness scale so CloudLayer can be overblown if desired. 
/// </summary>
[MemberGroup("CloudLayer")]
public float exposure
       {
       get
          {
          return Omni.self.GetVar(_ID + ".exposure").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".exposure", value.AsString());
          }
       }
/// <summary>
/// Abstract number which controls the curvature and height of the dome mesh. 
/// </summary>
[MemberGroup("CloudLayer")]
public float height
       {
       get
          {
          return Omni.self.GetVar(_ID + ".height").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".height", value.AsString());
          }
       }
[MemberGroup("CloudLayer")]
public arrayObject<Point2F> texDirection;
[MemberGroup("CloudLayer")]
public arrayObject<float> texScale;
[MemberGroup("CloudLayer")]
public arrayObject<float> texSpeed;
/// <summary>
/// An RGBA texture which should contain normals and opacity (density). 
/// </summary>
[MemberGroup("CloudLayer")]
public TypeImageFilename texture
       {
       get
          {
          return Omni.self.GetVar(_ID + ".texture").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".texture", value.AsString());
          }
       }
/// <summary>
/// Overall scalar to texture scroll speed. 
/// </summary>
[MemberGroup("CloudLayer")]
public float windSpeed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".windSpeed").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".windSpeed", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public CloudLayer_Base (){texDirection = new arrayObject<Point2F>(3,"texDirection","TypeVariable",false,this);    
texScale = new arrayObject<float>(3,"texScale","TypeVariable",false,this);    
texSpeed = new arrayObject<float>(3,"texSpeed","TypeVariable",false,this);    
}
}}
