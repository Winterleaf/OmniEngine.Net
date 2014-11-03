


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
    [TypeConverter(typeof(TypeConverterGeneric<GFXSamplerStateData_Base>))]
    public partial class GFXSamplerStateData_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GFXSamplerStateData_Base ts, string simobjectid)
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
        public static bool operator !=(GFXSamplerStateData_Base ts, string simobjectid)
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
        public static implicit operator string( GFXSamplerStateData_Base ts)
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
        public static implicit operator GFXSamplerStateData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GFXSamplerStateData_Base) Omni.self.getSimObject(simobjectid,typeof(GFXSamplerStateData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GFXSamplerStateData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GFXSamplerStateData_Base(int simobjectid)
            {
            return  (GFXSamplerStateData) Omni.self.getSimObject((uint)simobjectid,typeof(GFXSamplerStateData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GFXSamplerStateData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GFXSamplerStateData_Base(uint simobjectid)
            {
            return  (GFXSamplerStateData_Base) Omni.self.getSimObject(simobjectid,typeof(GFXSamplerStateData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The texture address mode for the u coordinate. The default is GFXAddressWrap. 
/// </summary>
[MemberGroup("Address Mode")]
public TypeGFXTextureAddressMode addressModeU
       {
       get
          {          return (TypeGFXTextureAddressMode) Omni.self.GetVar(_ID + ".addressModeU");
          }
       set
          {
          Omni.self.SetVar(_ID + ".addressModeU", value.ToString());
          }
       }
/// <summary>
/// The texture address mode for the v coordinate. The default is GFXAddressWrap. 
/// </summary>
[MemberGroup("Address Mode")]
public TypeGFXTextureAddressMode addressModeV
       {
       get
          {          return (TypeGFXTextureAddressMode) Omni.self.GetVar(_ID + ".addressModeV");
          }
       set
          {
          Omni.self.SetVar(_ID + ".addressModeV", value.ToString());
          }
       }
/// <summary>
/// The texture address mode for the w coordinate. The default is GFXAddressWrap. 
/// </summary>
[MemberGroup("Address Mode")]
public TypeGFXTextureAddressMode addressModeW
       {
       get
          {          return (TypeGFXTextureAddressMode) Omni.self.GetVar(_ID + ".addressModeW");
          }
       set
          {
          Omni.self.SetVar(_ID + ".addressModeW", value.ToString());
          }
       }
/// <summary>
/// The first alpha argument for the texture stage. The default value is GFXTATexture. 
/// </summary>
[MemberGroup("Alpha Op")]
public TypeGFXTextureArgument alphaArg1
       {
       get
          {          return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".alphaArg1");
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaArg1", value.ToString());
          }
       }
/// <summary>
/// The second alpha argument for the texture stage. The default value is GFXTADiffuse. 
/// </summary>
[MemberGroup("Alpha Op")]
public TypeGFXTextureArgument alphaArg2
       {
       get
          {          return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".alphaArg2");
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaArg2", value.ToString());
          }
       }
/// <summary>
/// The third alpha channel selector operand for triadic operations (multiply, add, and linearly interpolate). The default value is GFXTACurrent. 
/// </summary>
[MemberGroup("Alpha Op")]
public TypeGFXTextureArgument alphaArg3
       {
       get
          {          return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".alphaArg3");
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaArg3", value.ToString());
          }
       }
/// <summary>
/// The texture alpha blending operation. The default value is GFXTOPModulate. 
/// </summary>
[MemberGroup("Alpha Op")]
public TypeGFXTextureOp alphaOp
       {
       get
          {          return (TypeGFXTextureOp) Omni.self.GetVar(_ID + ".alphaOp");
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaOp", value.ToString());
          }
       }
/// <summary>
/// The first color argument for the texture stage. The default value is GFXTACurrent. 
/// </summary>
[MemberGroup("Color Op")]
public TypeGFXTextureArgument colorArg1
       {
       get
          {          return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".colorArg1");
          }
       set
          {
          Omni.self.SetVar(_ID + ".colorArg1", value.ToString());
          }
       }
/// <summary>
/// The second color argument for the texture stage. The default value is GFXTATexture. 
/// </summary>
[MemberGroup("Color Op")]
public TypeGFXTextureArgument colorArg2
       {
       get
          {          return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".colorArg2");
          }
       set
          {
          Omni.self.SetVar(_ID + ".colorArg2", value.ToString());
          }
       }
/// <summary>
/// The third color argument for triadic operations (multiply, add, and linearly interpolate). The default value is GFXTACurrent. 
/// </summary>
[MemberGroup("Color Op")]
public TypeGFXTextureArgument colorArg3
       {
       get
          {          return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".colorArg3");
          }
       set
          {
          Omni.self.SetVar(_ID + ".colorArg3", value.ToString());
          }
       }
/// <summary>
/// The texture magnification filter. The default is GFXTextureFilterLinear. 
/// </summary>
[MemberGroup("Filter State")]
public TypeGFXTextureFilterType magFilter
       {
       get
          {          return (TypeGFXTextureFilterType) Omni.self.GetVar(_ID + ".magFilter");
          }
       set
          {
          Omni.self.SetVar(_ID + ".magFilter", value.ToString());
          }
       }
/// <summary>
/// The maximum texture anisotropy. The default value is 1. 
/// </summary>
[MemberGroup("Filter State")]
public int maxAnisotropy
       {
       get
          {
          return Omni.self.GetVar(_ID + ".maxAnisotropy").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".maxAnisotropy", value.AsString());
          }
       }
/// <summary>
/// The texture minification filter. The default is GFXTextureFilterLinear. 
/// </summary>
[MemberGroup("Filter State")]
public TypeGFXTextureFilterType minFilter
       {
       get
          {          return (TypeGFXTextureFilterType) Omni.self.GetVar(_ID + ".minFilter");
          }
       set
          {
          Omni.self.SetVar(_ID + ".minFilter", value.ToString());
          }
       }
/// <summary>
/// The texture mipmap filter used during minification. The default is GFXTextureFilterLinear. 
/// </summary>
[MemberGroup("Filter State")]
public TypeGFXTextureFilterType mipFilter
       {
       get
          {          return (TypeGFXTextureFilterType) Omni.self.GetVar(_ID + ".mipFilter");
          }
       set
          {
          Omni.self.SetVar(_ID + ".mipFilter", value.ToString());
          }
       }
/// <summary>
/// The mipmap level of detail bias. The default value is zero. 
/// </summary>
[MemberGroup("Filter State")]
public float mipLODBias
       {
       get
          {
          return Omni.self.GetVar(_ID + ".mipLODBias").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".mipLODBias", value.AsString());
          }
       }
/// <summary>
/// The selection of the destination register for the result of this stage. The default is GFXTACurrent. 
/// </summary>
[MemberGroup("")]
public TypeGFXTextureArgument resultArg
       {
       get
          {          return (TypeGFXTextureArgument) Omni.self.GetVar(_ID + ".resultArg");
          }
       set
          {
          Omni.self.SetVar(_ID + ".resultArg", value.ToString());
          }
       }
/// <summary>
/// The texture color blending operation. The default value is GFXTOPDisable which disables the sampler. 
/// </summary>
[MemberGroup("Color Op")]
public TypeGFXTextureOp textureColorOp
       {
       get
          {          return (TypeGFXTextureOp) Omni.self.GetVar(_ID + ".textureColorOp");
          }
       set
          {
          Omni.self.SetVar(_ID + ".textureColorOp", value.ToString());
          }
       }
/// <summary>
/// Sets the texture transform state. The default is GFXTTFFDisable. 
/// </summary>
[MemberGroup("")]
public TypeGFXTextureTransformFlags textureTransform
       {
       get
          {          return (TypeGFXTextureTransformFlags) Omni.self.GetVar(_ID + ".textureTransform");
          }
       set
          {
          Omni.self.SetVar(_ID + ".textureTransform", value.ToString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GFXSamplerStateData_Base (){}
}}
