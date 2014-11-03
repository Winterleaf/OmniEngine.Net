


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
    [TypeConverter(typeof(TypeConverterGeneric<GFXStateBlockData_Base>))]
    public partial class GFXStateBlockData_Base: SimObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(GFXStateBlockData_Base ts, string simobjectid)
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
        public static bool operator !=(GFXStateBlockData_Base ts, string simobjectid)
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
        public static implicit operator string( GFXStateBlockData_Base ts)
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
        public static implicit operator GFXStateBlockData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (GFXStateBlockData_Base) Omni.self.getSimObject(simobjectid,typeof(GFXStateBlockData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( GFXStateBlockData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator GFXStateBlockData_Base(int simobjectid)
            {
            return  (GFXStateBlockData) Omni.self.getSimObject((uint)simobjectid,typeof(GFXStateBlockData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( GFXStateBlockData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator GFXStateBlockData_Base(uint simobjectid)
            {
            return  (GFXStateBlockData_Base) Omni.self.getSimObject(simobjectid,typeof(GFXStateBlockData_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// Set to true if the alpha test state is not all defaults. 
/// </summary>
[MemberGroup("Alpha Test")]
public bool alphaDefined
       {
       get
          {
          return Omni.self.GetVar(_ID + ".alphaDefined").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaDefined", value.AsString());
          }
       }
/// <summary>
/// Enables per-pixel alpha testing. The default is false. 
/// </summary>
[MemberGroup("Alpha Test")]
public bool alphaTestEnable
       {
       get
          {
          return Omni.self.GetVar(_ID + ".alphaTestEnable").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaTestEnable", value.AsString());
          }
       }
/// <summary>
/// The test function used to accept or reject a pixel based on its alpha value. The default is GFXCmpGreaterEqual. 
/// </summary>
[MemberGroup("Alpha Test")]
public TypeGFXCmpFunc alphaTestFunc
       {
       get
          {          return (TypeGFXCmpFunc) Omni.self.GetVar(_ID + ".alphaTestFunc");
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaTestFunc", value.ToString());
          }
       }
/// <summary>
/// The reference alpha value against which pixels are tested. The default is zero. 
/// </summary>
[MemberGroup("Alpha Test")]
public int alphaTestRef
       {
       get
          {
          return Omni.self.GetVar(_ID + ".alphaTestRef").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".alphaTestRef", value.AsString());
          }
       }
/// <summary>
/// Set to true if the alpha blend state is not all defaults. 
/// </summary>
[MemberGroup("Alpha Blending")]
public bool blendDefined
       {
       get
          {
          return Omni.self.GetVar(_ID + ".blendDefined").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".blendDefined", value.AsString());
          }
       }
/// <summary>
/// The destination blend state. The default is GFXBlendZero. 
/// </summary>
[MemberGroup("Alpha Blending")]
public TypeGFXBlend blendDest
       {
       get
          {          return (TypeGFXBlend) Omni.self.GetVar(_ID + ".blendDest");
          }
       set
          {
          Omni.self.SetVar(_ID + ".blendDest", value.ToString());
          }
       }
/// <summary>
/// Enables alpha blending. The default is false. 
/// </summary>
[MemberGroup("Alpha Blending")]
public bool blendEnable
       {
       get
          {
          return Omni.self.GetVar(_ID + ".blendEnable").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".blendEnable", value.AsString());
          }
       }
/// <summary>
/// The arithmetic operation applied to alpha blending. The default is GFXBlendOpAdd. 
/// </summary>
[MemberGroup("Alpha Blending")]
public TypeGFXBlendOp blendOp
       {
       get
          {          return (TypeGFXBlendOp) Omni.self.GetVar(_ID + ".blendOp");
          }
       set
          {
          Omni.self.SetVar(_ID + ".blendOp", value.ToString());
          }
       }
/// <summary>
/// The source blend state. The default is GFXBlendOne. 
/// </summary>
[MemberGroup("Alpha Blending")]
public TypeGFXBlend blendSrc
       {
       get
          {          return (TypeGFXBlend) Omni.self.GetVar(_ID + ".blendSrc");
          }
       set
          {
          Omni.self.SetVar(_ID + ".blendSrc", value.ToString());
          }
       }
/// <summary>
/// Enables alpha channel writes. The default is true. 
/// </summary>
[MemberGroup("Color Write")]
public bool colorWriteAlpha
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colorWriteAlpha").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colorWriteAlpha", value.AsString());
          }
       }
/// <summary>
/// Enables blue channel writes. The default is true. 
/// </summary>
[MemberGroup("Color Write")]
public bool colorWriteBlue
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colorWriteBlue").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colorWriteBlue", value.AsString());
          }
       }
/// <summary>
/// Set to true if the color write state is not all defaults. 
/// </summary>
[MemberGroup("Color Write")]
public bool colorWriteDefined
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colorWriteDefined").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colorWriteDefined", value.AsString());
          }
       }
/// <summary>
/// Enables green channel writes. The default is true. 
/// </summary>
[MemberGroup("Color Write")]
public bool colorWriteGreen
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colorWriteGreen").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colorWriteGreen", value.AsString());
          }
       }
/// <summary>
/// Enables red channel writes. The default is true. 
/// </summary>
[MemberGroup("Color Write")]
public bool colorWriteRed
       {
       get
          {
          return Omni.self.GetVar(_ID + ".colorWriteRed").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".colorWriteRed", value.AsString());
          }
       }
/// <summary>
/// Set to true if the culling state is not all defaults. 
/// </summary>
[MemberGroup("Culling")]
public bool cullDefined
       {
       get
          {
          return Omni.self.GetVar(_ID + ".cullDefined").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".cullDefined", value.AsString());
          }
       }
/// <summary>
/// Defines how back facing triangles are culled if at all. The default is GFXCullCCW. 
/// </summary>
[MemberGroup("Culling")]
public TypeGFXCullMode cullMode
       {
       get
          {          return (TypeGFXCullMode) Omni.self.GetVar(_ID + ".cullMode");
          }
       set
          {
          Omni.self.SetVar(_ID + ".cullMode", value.ToString());
          }
       }
/// <summary>
/// Enables fixed function lighting when rendering without a shader on geometry with vertex normals. The default is false. 
/// </summary>
[MemberGroup("Fixed Function")]
public bool ffLighting
       {
       get
          {
          return Omni.self.GetVar(_ID + ".ffLighting").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".ffLighting", value.AsString());
          }
       }
/// <summary>
/// Set to true if the sampler states are not all defaults. 
/// </summary>
[MemberGroup("Sampler States")]
public bool samplersDefined
       {
       get
          {
          return Omni.self.GetVar(_ID + ".samplersDefined").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".samplersDefined", value.AsString());
          }
       }
[MemberGroup("Sampler States")]
public arrayObject<GFXSamplerStateData> samplerStates;
/// <summary>
/// Set to true if the seperate alpha blend state is not all defaults. 
/// </summary>
[MemberGroup("Separate Alpha Blending")]
public bool separateAlphaBlendDefined
       {
       get
          {
          return Omni.self.GetVar(_ID + ".separateAlphaBlendDefined").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".separateAlphaBlendDefined", value.AsString());
          }
       }
/// <summary>
/// The destination blend state. The default is GFXBlendZero. 
/// </summary>
[MemberGroup("Separate Alpha Blending")]
public TypeGFXBlend separateAlphaBlendDest
       {
       get
          {          return (TypeGFXBlend) Omni.self.GetVar(_ID + ".separateAlphaBlendDest");
          }
       set
          {
          Omni.self.SetVar(_ID + ".separateAlphaBlendDest", value.ToString());
          }
       }
/// <summary>
/// Enables the separate blend mode for the alpha channel. The default is false. 
/// </summary>
[MemberGroup("Separate Alpha Blending")]
public bool separateAlphaBlendEnable
       {
       get
          {
          return Omni.self.GetVar(_ID + ".separateAlphaBlendEnable").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".separateAlphaBlendEnable", value.AsString());
          }
       }
/// <summary>
/// The arithmetic operation applied to separate alpha blending. The default is GFXBlendOpAdd. 
/// </summary>
[MemberGroup("Separate Alpha Blending")]
public TypeGFXBlendOp separateAlphaBlendOp
       {
       get
          {          return (TypeGFXBlendOp) Omni.self.GetVar(_ID + ".separateAlphaBlendOp");
          }
       set
          {
          Omni.self.SetVar(_ID + ".separateAlphaBlendOp", value.ToString());
          }
       }
/// <summary>
/// The source blend state. The default is GFXBlendOne. 
/// </summary>
[MemberGroup("Separate Alpha Blending")]
public TypeGFXBlend separateAlphaBlendSrc
       {
       get
          {          return (TypeGFXBlend) Omni.self.GetVar(_ID + ".separateAlphaBlendSrc");
          }
       set
          {
          Omni.self.SetVar(_ID + ".separateAlphaBlendSrc", value.ToString());
          }
       }
/// <summary>
/// Set to true if the stencil state is not all defaults. 
/// </summary>
[MemberGroup("Stencil")]
public bool stencilDefined
       {
       get
          {
          return Omni.self.GetVar(_ID + ".stencilDefined").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".stencilDefined", value.AsString());
          }
       }
/// <summary>
/// Enables stenciling. The default is false. 
/// </summary>
[MemberGroup("Stencil")]
public bool stencilEnable
       {
       get
          {
          return Omni.self.GetVar(_ID + ".stencilEnable").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".stencilEnable", value.AsString());
          }
       }
/// <summary>
/// The stencil operation to perform if the stencil test fails. The default is GFXStencilOpKeep. 
/// </summary>
[MemberGroup("Stencil")]
public TypeGFXStencilOp stencilFailOp
       {
       get
          {          return (TypeGFXStencilOp) Omni.self.GetVar(_ID + ".stencilFailOp");
          }
       set
          {
          Omni.self.SetVar(_ID + ".stencilFailOp", value.ToString());
          }
       }
/// <summary>
/// The comparison function to test the reference value to a stencil buffer entry. The default is GFXCmpNever. 
/// </summary>
[MemberGroup("Stencil")]
public TypeGFXCmpFunc stencilFunc
       {
       get
          {          return (TypeGFXCmpFunc) Omni.self.GetVar(_ID + ".stencilFunc");
          }
       set
          {
          Omni.self.SetVar(_ID + ".stencilFunc", value.ToString());
          }
       }
/// <summary>
/// The mask applied to the reference value and each stencil buffer entry to determine the significant bits for the stencil test. The default is 0xFFFFFFFF. 
/// </summary>
[MemberGroup("Stencil")]
public int stencilMask
       {
       get
          {
          return Omni.self.GetVar(_ID + ".stencilMask").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".stencilMask", value.AsString());
          }
       }
/// <summary>
/// The stencil operation to perform if both the stencil and the depth tests pass. The default is GFXStencilOpKeep. 
/// </summary>
[MemberGroup("Stencil")]
public TypeGFXStencilOp stencilPassOp
       {
       get
          {          return (TypeGFXStencilOp) Omni.self.GetVar(_ID + ".stencilPassOp");
          }
       set
          {
          Omni.self.SetVar(_ID + ".stencilPassOp", value.ToString());
          }
       }
/// <summary>
/// The reference value for the stencil test. The default is zero. 
/// </summary>
[MemberGroup("Stencil")]
public int stencilRef
       {
       get
          {
          return Omni.self.GetVar(_ID + ".stencilRef").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".stencilRef", value.AsString());
          }
       }
/// <summary>
/// The write mask applied to values written into the stencil buffer. The default is 0xFFFFFFFF. 
/// </summary>
[MemberGroup("Stencil")]
public int stencilWriteMask
       {
       get
          {
          return Omni.self.GetVar(_ID + ".stencilWriteMask").AsInt();
          }
       set
          {
          Omni.self.SetVar(_ID + ".stencilWriteMask", value.AsString());
          }
       }
/// <summary>
/// The stencil operation to perform if the stencil test passes and the depth test fails. The default is GFXStencilOpKeep. 
/// </summary>
[MemberGroup("Stencil")]
public TypeGFXStencilOp stencilZFailOp
       {
       get
          {          return (TypeGFXStencilOp) Omni.self.GetVar(_ID + ".stencilZFailOp");
          }
       set
          {
          Omni.self.SetVar(_ID + ".stencilZFailOp", value.ToString());
          }
       }
/// <summary>
/// The color used for multiple-texture blending with the GFXTATFactor texture-blending argument or      the GFXTOPBlendFactorAlpha texture-blending operation. The default is opaque white (255, 255, 255, 255). 
/// </summary>
[MemberGroup("Sampler States")]
public ColorI textureFactor
       {
       get
          {
          return Omni.self.GetVar(_ID + ".textureFactor").AsColorI();
          }
       set
          {
          Omni.self.SetVar(_ID + ".textureFactor", value.AsString());
          }
       }
/// <summary>
/// Enables fixed function vertex coloring when rendering without a shader. The default is false. 
/// </summary>
[MemberGroup("Fixed Function")]
public bool vertexColorEnable
       {
       get
          {
          return Omni.self.GetVar(_ID + ".vertexColorEnable").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".vertexColorEnable", value.AsString());
          }
       }
/// <summary>
/// A floating-point bias used when comparing depth values. The default is zero. 
/// </summary>
[MemberGroup("Depth")]
public float zBias
       {
       get
          {
          return Omni.self.GetVar(_ID + ".zBias").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".zBias", value.AsString());
          }
       }
/// <summary>
/// Set to true if the depth state is not all defaults. 
/// </summary>
[MemberGroup("Depth")]
public bool zDefined
       {
       get
          {
          return Omni.self.GetVar(_ID + ".zDefined").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".zDefined", value.AsString());
          }
       }
/// <summary>
/// Enables z-buffer reads. The default is true. 
/// </summary>
[MemberGroup("Depth")]
public bool zEnable
       {
       get
          {
          return Omni.self.GetVar(_ID + ".zEnable").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".zEnable", value.AsString());
          }
       }
/// <summary>
/// The depth comparision function which a pixel must pass to be written to the z-buffer. The default is GFXCmpLessEqual. 
/// </summary>
[MemberGroup("Depth")]
public TypeGFXCmpFunc zFunc
       {
       get
          {          return (TypeGFXCmpFunc) Omni.self.GetVar(_ID + ".zFunc");
          }
       set
          {
          Omni.self.SetVar(_ID + ".zFunc", value.ToString());
          }
       }
/// <summary>
/// An additional floating-point bias based on the maximum depth slop of the triangle being rendered. The default is zero. 
/// </summary>
[MemberGroup("Depth")]
public float zSlopeBias
       {
       get
          {
          return Omni.self.GetVar(_ID + ".zSlopeBias").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".zSlopeBias", value.AsString());
          }
       }
/// <summary>
/// Enables z-buffer writes. The default is true. 
/// </summary>
[MemberGroup("Depth")]
public bool zWriteEnable
       {
       get
          {
          return Omni.self.GetVar(_ID + ".zWriteEnable").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".zWriteEnable", value.AsString());
          }
       }

#endregion
#region Member Functions

#endregion
#region T3D Callbacks

#endregion
public GFXStateBlockData_Base (){samplerStates = new arrayObject<GFXSamplerStateData>(16,"samplerStates","T3DObject",false,this);    
}
}}
