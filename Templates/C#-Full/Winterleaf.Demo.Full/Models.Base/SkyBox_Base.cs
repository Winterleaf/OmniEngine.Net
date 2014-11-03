


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
    [TypeConverter(typeof(TypeConverterGeneric<SkyBox_Base>))]
    public partial class SkyBox_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(SkyBox_Base ts, string simobjectid)
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
        public static bool operator !=(SkyBox_Base ts, string simobjectid)
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
        public static implicit operator string( SkyBox_Base ts)
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
        public static implicit operator SkyBox_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (SkyBox_Base) Omni.self.getSimObject(simobjectid,typeof(SkyBox_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( SkyBox_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator SkyBox_Base(int simobjectid)
            {
            return  (SkyBox) Omni.self.getSimObject((uint)simobjectid,typeof(SkyBox_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( SkyBox_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator SkyBox_Base(uint simobjectid)
            {
            return  (SkyBox_Base) Omni.self.getSimObject(simobjectid,typeof(SkyBox_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// If false the bottom of the skybox is not rendered. 
/// </summary>
[MemberGroup("Sky Box")]
public bool drawBottom
       {
       get
          {
          return Omni.self.GetVar(_ID + ".drawBottom").AsBool();
          }
       set
          {
          Omni.self.SetVar(_ID + ".drawBottom", value.AsString());
          }
       }
/// <summary>
/// The height (0-1) of the fog band from the horizon to the top of the SkyBox. 
/// </summary>
[MemberGroup("Sky Box")]
public float fogBandHeight
       {
       get
          {
          return Omni.self.GetVar(_ID + ".fogBandHeight").AsFloat();
          }
       set
          {
          Omni.self.SetVar(_ID + ".fogBandHeight", value.AsString());
          }
       }
/// <summary>
/// The name of a cubemap material for the sky box. 
/// </summary>
[MemberGroup("Sky Box")]
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

#endregion
#region Member Functions
/// <summary>
/// )
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void postApply(){

pInvokes.m_ts.fn_SkyBox_postApply(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public SkyBox_Base (){}
}}
