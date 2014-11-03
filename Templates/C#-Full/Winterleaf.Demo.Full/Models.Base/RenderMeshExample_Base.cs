


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
    [TypeConverter(typeof(TypeConverterGeneric<RenderMeshExample_Base>))]
    public partial class RenderMeshExample_Base: SceneObject
{

#region ProxyObjects Operator Overrides
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(RenderMeshExample_Base ts, string simobjectid)
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
        public static bool operator !=(RenderMeshExample_Base ts, string simobjectid)
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
        public static implicit operator string( RenderMeshExample_Base ts)
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
        public static implicit operator RenderMeshExample_Base(string ts)
            {
            uint simobjectid = resolveobject(ts);
           return  (RenderMeshExample_Base) Omni.self.getSimObject(simobjectid,typeof(RenderMeshExample_Base));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int( RenderMeshExample_Base ts)
            {
            return (int)ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static implicit operator RenderMeshExample_Base(int simobjectid)
            {
            return  (RenderMeshExample) Omni.self.getSimObject((uint)simobjectid,typeof(RenderMeshExample_Base));
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint( RenderMeshExample_Base ts)
            {
            return ts._iID;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static implicit operator RenderMeshExample_Base(uint simobjectid)
            {
            return  (RenderMeshExample_Base) Omni.self.getSimObject(simobjectid,typeof(RenderMeshExample_Base));
            }
#endregion
#region Init Persists
/// <summary>
/// The name of the material used to render the mesh. 
/// </summary>
[MemberGroup("Rendering")]
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
/// A utility method for forcing a network update.)
/// 
/// </summary>
[MemberFunctionConsoleInteraction(true)]
public  void postApply(){

pInvokes.m_ts.fnRenderMeshExample_postApply(_ID);
}

#endregion
#region T3D Callbacks

#endregion
public RenderMeshExample_Base (){}
}}
