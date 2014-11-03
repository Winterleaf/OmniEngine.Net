


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
    [TypeConverter(typeof(TypeConverterGeneric<DecalData_Base>))]
    public partial class DecalData_Base: SimDataBlock
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(DecalData_Base ts, string simobjectid)
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
        public static bool operator !=(DecalData_Base ts, string simobjectid)
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
        public static implicit operator string( DecalData_Base ts)
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
        public static implicit operator DecalData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (DecalData_Base) Omni.self.getSimObject(simobjectid,typeof(DecalData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( DecalData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator DecalData_Base(int simobjectid)
            {
            return  (DecalData) Omni.self.getSimObject((uint)simobjectid,typeof(DecalData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( DecalData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator DecalData_Base(uint simobjectid)
            {
            return  (DecalData_Base) Omni.self.getSimObject(simobjectid,typeof(DecalData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The angle in degrees used to clip geometry that faces away from the      decal projection direction. 
/// </summary>
[MemberGroup("Rendering")]
public float clippingAngle
       {
       get
          {
          return Omni.self.GetVar(_ID + ".clippingAngle").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".clippingAngle", value.AsString());
          }
       }
/// <summary>
/// @brief LOD value - size in pixels at which decals of this type are      fully faded out.\n\n     This should be a smaller value than #fadeStartPixelSize. 
/// </summary>
[MemberGroup("Rendering")]
public float fadeEndPixelSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeEndPixelSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeEndPixelSize", value.AsString());
          }
       }
/// <summary>
/// @brief LOD value - size in pixels at which decals of this type begin      to fade out.\n\n     This should be a larger value than #fadeEndPixelSize. However, you may      also set this to a negative value to disable lod-based fading. 
/// </summary>
[MemberGroup("Rendering")]
public float fadeStartPixelSize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeStartPixelSize").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeStartPixelSize", value.AsString());
          }
       }
/// <summary>
/// @brief Time (in milliseconds) over which to fade out the decal before      deleting it at the end of its lifetime.\n\n     @see lifeSpan 
/// </summary>
[MemberGroup("Decal")]
public int fadeTime
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fadeTime").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fadeTime", value.AsString());
          }
       }
/// <summary>
/// Index of the texture rectangle within the imagemap to use for this decal. 
/// </summary>
[MemberGroup("Texturing")]
public int frame
       {
       get
          {
          return Omni.self.GetVar(_ID + ".frame").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".frame", value.AsString());
          }
       }
/// <summary>
/// Time (in milliseconds) before this decal will be automatically deleted. 
/// </summary>
[MemberGroup("Decal")]
public int lifeSpan
       {
       get
          {
          return Omni.self.GetVar(_ID + ".lifeSpan").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".lifeSpan", value.AsString());
          }
       }
/// <summary>
/// Material to use for this decal. 
/// </summary>
[MemberGroup("Decal")]
public TypeMaterialName material
       {
       get
          {
          return Omni.self.GetVar(_ID + ".material").AsTypeMaterialName();
          }
       set
          {
          Omni.self.SetVar(_ID + ".material", value.AsString());
          }
       }
/// <summary>
/// If true, a random frame from the imagemap is selected for each      instance of the decal. 
/// </summary>
[MemberGroup("Texturing")]
public bool randomize
       {
       get
          {
          return Omni.self.GetVar(_ID + ".randomize").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".randomize", value.AsString());
          }
       }
/// <summary>
/// Default renderPriority for decals of this type (determines draw      order when decals overlap). 
/// </summary>
[MemberGroup("Rendering")]
public sbyte renderPriority
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderPriority").AsSbyte();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderPriority", value.AsString());
          }
       }
/// <summary>
/// Width and height of the decal in meters before scale is applied. 
/// </summary>
[MemberGroup("Decal")]
public float size
       {
       get
          {
          return Omni.self.GetVar(_ID + ".size").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".size", value.AsString());
          }
       }
/// <summary>
/// @brief Number of columns in the supplied imagemap.\n\n     Use #texRows and #texCols if the imagemap frames are arranged in a      grid; use #textureCoords to manually specify UV coordinates for      irregular sized frames. 
/// </summary>
[MemberGroup("Texturing")]
public int texCols
       {
       get
          {
          return Omni.self.GetVar(_ID + ".texCols").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".texCols", value.AsString());
          }
       }
/// <summary>
/// @brief Number of rows in the supplied imagemap.\n\n     Use #texRows and #texCols if the imagemap frames are arranged in a      grid; use #textureCoords to manually specify UV coordinates for      irregular sized frames. 
/// </summary>
[MemberGroup("Texturing")]
public int texRows
       {
       get
          {
          return Omni.self.GetVar(_ID + ".texRows").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".texRows", value.AsString());
          }
       }
/// <summary>
/// Number of individual frames in the imagemap (maximum 16). 
/// </summary>
[MemberGroup("Texturing")]
public int textureCoordCount
       {
       get
          {
          return Omni.self.GetVar(_ID + ".textureCoordCount").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".textureCoordCount", value.AsString());
          }
       }
[MemberGroup("Texturing")]
public arrayObject<RectF> textureCoords;

#endregion
#region Member Functions
/// <summary>
/// Recompute the imagemap sub-texture rectangles for this DecalData.
///    @tsexample
///    // Inform the decal object to reload its imagemap and frame data.
///    %decalData.texRows = 4;
///    %decalData.postApply();
///    @endtsexample)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void postApply(){

pInvokes.m_ts.fnDecalData_postApply(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public DecalData_Base (){textureCoords = new arrayObject<RectF>(16,"textureCoords","TypeVariable",false,this);    
}
}}
