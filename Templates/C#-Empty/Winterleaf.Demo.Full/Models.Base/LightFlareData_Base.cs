


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
    [TypeConverter(typeof(TypeConverterGeneric<LightFlareData_Base>))]
    public partial class LightFlareData_Base: SimDataBlock
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(LightFlareData_Base ts, string simobjectid)
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
        public static bool operator !=(LightFlareData_Base ts, string simobjectid)
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
        public static implicit operator string( LightFlareData_Base ts)
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
        public static implicit operator LightFlareData_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (LightFlareData_Base) Omni.self.getSimObject(simobjectid,typeof(LightFlareData_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( LightFlareData_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator LightFlareData_Base(int simobjectid)
            {
            return  (LightFlareData) Omni.self.getSimObject((uint)simobjectid,typeof(LightFlareData_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( LightFlareData_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator LightFlareData_Base(uint simobjectid)
            {
            return  (LightFlareData_Base) Omni.self.getSimObject(simobjectid,typeof(LightFlareData_Base));
            }
#endregion
#region Init Persists
[MemberGroup("FlareElements")]
public arrayObject<float> elementDist;
[MemberGroup("FlareElements")]
public arrayObject<RectF> elementRect;
[MemberGroup("FlareElements")]
public arrayObject<bool> elementRotate;
[MemberGroup("FlareElements")]
public arrayObject<float> elementScale;
[MemberGroup("FlareElements")]
public arrayObject<ColorF> elementTint;
[MemberGroup("FlareElements")]
public arrayObject<bool> elementUseLightColor;
/// <summary>
/// Allows the user to disable this flare globally for any lights referencing it. 
/// </summary>
[MemberGroup("FlareElements")]
public bool flareEnabled
       {
       get
          {
          return Omni.self.GetVar(_ID + ".flareEnabled").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".flareEnabled", value.AsString());
          }
       }
/// <summary>
/// The texture / sprite sheet for this flare. 
/// </summary>
[MemberGroup("FlareElements")]
public TypeImageFilename flareTexture
       {
       get
          {
          return Omni.self.GetVar(_ID + ".flareTexture").AsTypeImageFilename();
          }
       set
          {
          Omni.self.SetVar(_ID + ".flareTexture", value.AsString());
          }
       }
/// <summary>
/// If positive an occlusion query is used to test flare visibility, else it uses simple raycasts. 
/// </summary>
[MemberGroup("LightFlareData")]
public float occlusionRadius
       {
       get
          {
          return Omni.self.GetVar(_ID + ".occlusionRadius").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".occlusionRadius", value.AsString());
          }
       }
/// <summary>
/// Size scale applied to all elements of the flare. 
/// </summary>
[MemberGroup("LightFlareData")]
public float overallScale
       {
       get
          {
          return Omni.self.GetVar(_ID + ".overallScale").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".overallScale", value.AsString());
          }
       }
/// <summary>
/// If false the flare does not render in reflections, else only non-zero distance elements are rendered. 
/// </summary>
[MemberGroup("LightFlareData")]
public bool renderReflectPass
       {
       get
          {
          return Omni.self.GetVar(_ID + ".renderReflectPass").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".renderReflectPass", value.AsString());
          }
       }

#endregion
#region Member Functions
/// <summary>
/// Intended as a helper to developers and editor scripts.
///                    Force trigger an inspectPostApply
///                    )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void apply(){

pInvokes.m_ts.fnLightFlareData_apply(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public LightFlareData_Base (){elementDist = new arrayObject<float>(20,"elementDist","TypeVariable",false,this);    
elementRect = new arrayObject<RectF>(20,"elementRect","TypeVariable",false,this);    
elementRotate = new arrayObject<bool>(20,"elementRotate","TypeVariable",false,this);    
elementScale = new arrayObject<float>(20,"elementScale","TypeVariable",false,this);    
elementTint = new arrayObject<ColorF>(20,"elementTint","TypeVariable",false,this);    
elementUseLightColor = new arrayObject<bool>(20,"elementUseLightColor","TypeVariable",false,this);    
}
}}
